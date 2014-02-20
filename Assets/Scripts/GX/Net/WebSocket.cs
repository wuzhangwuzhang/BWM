﻿using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GX.Net
{
	public class WebSocket
	{
		#region Proxy
		public interface IProxy
		{
			bool Connected { get; }
			void Open(string url);
			void Send(byte[] data);
			byte[] Receive();

			IEnumerator Run();
		}
		public static IProxy Proxy { get; set; }

		#region UniWeb WebSocket
#if !UNITY_WP8 || UNITY_EDITOR
		class UniWebWebSocket : IProxy
		{
			HTTP.WebSocket socket;
			readonly object syncRoot = new object();
			Queue<byte[]> queue;

			#region IProxy 成员
			public bool Connected { get { return socket.connected; } }

			public void Open(string url)
			{
				queue = new Queue<byte[]>();
				socket = new HTTP.WebSocket();
				socket.OnBinaryMessageRecv += buf =>
				{
					lock (syncRoot)
					{
						queue.Enqueue(buf);
					}
				};

				// UniWeb can only work on http protocol. 
				// http://answers.unity3d.com/questions/575963/websocket-implementation-that-works-in-ide-and-on.html
				url = Regex.Replace(url, "^ws", "http");
				socket.Connect(url);
			}

			public void Send(byte[] data)
			{
				socket.Send(data);
			}

			public byte[] Receive()
			{
				if (queue == null)
					return null;
				lock (syncRoot)
				{
					if (queue.Count == 0)
						return null;
					return queue.Dequeue();
				}
			}

			public IEnumerator Run()
			{
				return socket.Dispatcher();
			}

			#endregion
		}
#endif
		#endregion

		static WebSocket()
		{
#if !UNITY_WP8 || UNITY_EDITOR
			Proxy = new UniWebWebSocket();
#endif
		}
		#endregion

		private readonly MessageSerializer serizlizer = new MessageSerializer();

		public void Open(string url = "ws://echo.websocket.org")
		{
			Debug.Log("WebSocket Open: " + url);
			Proxy.Open(url);
		}

		public void Send(ProtoBuf.IExtensible message)
		{
			var buf = serizlizer.Serialize(message);
			Proxy.Send(buf);
		}

		public void Send(params ProtoBuf.IExtensible[] message)
		{
			var buf = serizlizer.Serialize(message);
			Proxy.Send(buf);
		}

		public IEnumerable<ProtoBuf.IExtensible> Receive()
		{
			while (true)
			{
				var buf = Proxy.Receive();
				if (buf == null)
					break;
				using (var mem = new MemoryStream(buf))
				{
					while (mem.Position < mem.Length)
					{
						var msg = serizlizer.Deserialize(mem);
						yield return msg;
					}
				}
			}
		}

		public IEnumerator Run()
		{
			return Proxy.Run();
		}
	}
}