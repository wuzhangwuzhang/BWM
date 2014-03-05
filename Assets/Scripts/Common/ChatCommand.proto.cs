//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ChatCommand.proto
namespace Cmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Chat")]
  public partial class Chat : global::ProtoBuf.IExtensible
  {
    public Chat() {}
    
    [global::ProtoBuf.ProtoContract(Name=@"Param")]
    public enum Param
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CommonChatUserCmd_CS", Value=1)]
      CommonChatUserCmd_CS = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GMCommandChatUserCmd_C", Value=2)]
      GMCommandChatUserCmd_C = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MessageBoxChatUserCmd_S", Value=3)]
      MessageBoxChatUserCmd_S = 3
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CommonChatUserCmd_CS")]
  public partial class CommonChatUserCmd_CS : global::ProtoBuf.IExtensible
  {
    public CommonChatUserCmd_CS() {}
    
    private ulong _charid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private string _charname = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"charname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string charname
    {
      get { return _charname; }
      set { _charname = value; }
    }
    private bool _sexman = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"sexman", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool sexman
    {
      get { return _sexman; }
      set { _sexman = value; }
    }
    private Cmd.CommonChatUserCmd_CS.ChatPos _chatpos;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"chatpos", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Cmd.CommonChatUserCmd_CS.ChatPos chatpos
    {
      get { return _chatpos; }
      set { _chatpos = value; }
    }
    private string _info;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string info
    {
      get { return _info; }
      set { _info = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ChatPos")]
    public enum ChatPos
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ChatPos_Normal", Value=1)]
      ChatPos_Normal = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ChatPos_Sys", Value=2)]
      ChatPos_Sys = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ChatPos_Tips", Value=4)]
      ChatPos_Tips = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ChatPos_Pop", Value=8)]
      ChatPos_Pop = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ChatPos_Private", Value=16)]
      ChatPos_Private = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ChatPos_Important", Value=32)]
      ChatPos_Important = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ChatPos_Honor", Value=64)]
      ChatPos_Honor = 64,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ChatPos_Gm", Value=128)]
      ChatPos_Gm = 128
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GMCommandChatUserCmd_C")]
  public partial class GMCommandChatUserCmd_C : global::ProtoBuf.IExtensible
  {
    public GMCommandChatUserCmd_C() {}
    
    private ulong _charid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private string _charname;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"charname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string charname
    {
      get { return _charname; }
      set { _charname = value; }
    }
    private bool _sexman;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"sexman", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool sexman
    {
      get { return _sexman; }
      set { _sexman = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MessageBoxChatUserCmd_S")]
  public partial class MessageBoxChatUserCmd_S : global::ProtoBuf.IExtensible
  {
    public MessageBoxChatUserCmd_S() {}
    
    private string _btnleft = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"btnleft", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string btnleft
    {
      get { return _btnleft; }
      set { _btnleft = value; }
    }
    private string _btnmiddle = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"btnmiddle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string btnmiddle
    {
      get { return _btnmiddle; }
      set { _btnmiddle = value; }
    }
    private string _btnright = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"btnright", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string btnright
    {
      get { return _btnright; }
      set { _btnright = value; }
    }
    private string _info = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string info
    {
      get { return _info; }
      set { _info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"ChatType")]
    public enum ChatType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ChatType_Map", Value=2)]
      ChatType_Map = 2
    }
  
}