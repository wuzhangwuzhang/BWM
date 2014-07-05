//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: questcommand.proto
// Note: requires additional types generated from: common.proto
// Note: requires additional types generated from: savedata.proto
namespace Cmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Quest")]
  public partial class Quest : global::ProtoBuf.IExtensible
  {
    public Quest() {}
    
    [global::ProtoBuf.ProtoContract(Name=@"Param")]
    public enum Param
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddQuestTraceQuestUserCmd_S", Value=1)]
      AddQuestTraceQuestUserCmd_S = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RefreshQeustStateQuestUserCmd_S", Value=3)]
      RefreshQeustStateQuestUserCmd_S = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RemoveQuestQuestUserCmd_CS", Value=4)]
      RemoveQuestQuestUserCmd_CS = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RequestAcceptQuestQuestUserCmd_CS", Value=5)]
      RequestAcceptQuestQuestUserCmd_CS = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RequestFinishQuestQuestUserCmd_CS", Value=6)]
      RequestFinishQuestQuestUserCmd_CS = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RequestClickQuestTraceQuestUserCmd_C", Value=7)]
      RequestClickQuestTraceQuestUserCmd_C = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ReturnClickQuestTraceQuestUserCmd_S", Value=8)]
      ReturnClickQuestTraceQuestUserCmd_S = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RequestQuestDescQuestUserCmd_C", Value=9)]
      RequestQuestDescQuestUserCmd_C = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ReturnQuestDetailInfoQuestUserCmd_S", Value=10)]
      ReturnQuestDetailInfoQuestUserCmd_S = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OpenStageDialogQuestUserCmd_S", Value=11)]
      OpenStageDialogQuestUserCmd_S = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RequestOpenStageQuestUserCmd_C", Value=12)]
      RequestOpenStageQuestUserCmd_C = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ReturnOpenStageQuestUserCmd_S", Value=13)]
      ReturnOpenStageQuestUserCmd_S = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PrepairFinishStageQuestUserCmd_S", Value=14)]
      PrepairFinishStageQuestUserCmd_S = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RequestFinishStageQuestUserCmd_C", Value=15)]
      RequestFinishStageQuestUserCmd_C = 15
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"QuestTrace")]
  public partial class QuestTrace : global::ProtoBuf.IExtensible
  {
    public QuestTrace() {}
    
    private Cmd.SaveQuest _squest;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"squest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.SaveQuest squest
    {
      get { return _squest; }
      set { _squest = value; }
    }
    private string _desc;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AddQuestTraceQuestUserCmd_S")]
  public partial class AddQuestTraceQuestUserCmd_S : global::ProtoBuf.IExtensible
  {
    public AddQuestTraceQuestUserCmd_S() {}
    
    private Cmd.QuestTrace _quest;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"quest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.QuestTrace quest
    {
      get { return _quest; }
      set { _quest = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RefreshQeustStateQuestUserCmd_S")]
  public partial class RefreshQeustStateQuestUserCmd_S : global::ProtoBuf.IExtensible
  {
    public RefreshQeustStateQuestUserCmd_S() {}
    
    private Cmd.SaveQuest _squest;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"squest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.SaveQuest squest
    {
      get { return _squest; }
      set { _squest = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RemoveQuestQuestUserCmd_CS")]
  public partial class RemoveQuestQuestUserCmd_CS : global::ProtoBuf.IExtensible
  {
    public RemoveQuestQuestUserCmd_CS() {}
    
    private uint _questid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"questid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint questid
    {
      get { return _questid; }
      set { _questid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestAcceptQuestQuestUserCmd_CS")]
  public partial class RequestAcceptQuestQuestUserCmd_CS : global::ProtoBuf.IExtensible
  {
    public RequestAcceptQuestQuestUserCmd_CS() {}
    
    private uint _questid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"questid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint questid
    {
      get { return _questid; }
      set { _questid = value; }
    }
    private ulong _npctempid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"npctempid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong npctempid
    {
      get { return _npctempid; }
      set { _npctempid = value; }
    }
    private ulong _charid = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestFinishQuestQuestUserCmd_CS")]
  public partial class RequestFinishQuestQuestUserCmd_CS : global::ProtoBuf.IExtensible
  {
    public RequestFinishQuestQuestUserCmd_CS() {}
    
    private uint _questid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"questid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint questid
    {
      get { return _questid; }
      set { _questid = value; }
    }
    private ulong _npctempid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"npctempid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong npctempid
    {
      get { return _npctempid; }
      set { _npctempid = value; }
    }
    private ulong _charid = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestClickQuestTraceQuestUserCmd_C")]
  public partial class RequestClickQuestTraceQuestUserCmd_C : global::ProtoBuf.IExtensible
  {
    public RequestClickQuestTraceQuestUserCmd_C() {}
    
    private uint _questid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"questid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint questid
    {
      get { return _questid; }
      set { _questid = value; }
    }
    private ulong _npctempid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"npctempid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong npctempid
    {
      get { return _npctempid; }
      set { _npctempid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldPosition")]
  public partial class WorldPosition : global::ProtoBuf.IExtensible
  {
    public WorldPosition() {}
    
    private Cmd.Pos _pos = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Cmd.Pos pos
    {
      get { return _pos; }
      set { _pos = value; }
    }
    private uint _mapid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"mapid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint mapid
    {
      get { return _mapid; }
      set { _mapid = value; }
    }
    private uint _countryid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"countryid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint countryid
    {
      get { return _countryid; }
      set { _countryid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReturnClickQuestTraceQuestUserCmd_S")]
  public partial class ReturnClickQuestTraceQuestUserCmd_S : global::ProtoBuf.IExtensible
  {
    public ReturnClickQuestTraceQuestUserCmd_S() {}
    
    private uint _questid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"questid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint questid
    {
      get { return _questid; }
      set { _questid = value; }
    }
    private Cmd.ClickQuestTaceEvent _event;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"event", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Cmd.ClickQuestTaceEvent @event
    {
      get { return _event; }
      set { _event = value; }
    }
    private Cmd.WorldPosition _position = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Cmd.WorldPosition position
    {
      get { return _position; }
      set { _position = value; }
    }
    private uint _npcbaseid = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"npcbaseid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint npcbaseid
    {
      get { return _npcbaseid; }
      set { _npcbaseid = value; }
    }
    private string _dialogname = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"dialogname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string dialogname
    {
      get { return _dialogname; }
      set { _dialogname = value; }
    }
    private bool _repeatclick = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"repeatclick", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool repeatclick
    {
      get { return _repeatclick; }
      set { _repeatclick = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestQuestDescQuestUserCmd_C")]
  public partial class RequestQuestDescQuestUserCmd_C : global::ProtoBuf.IExtensible
  {
    public RequestQuestDescQuestUserCmd_C() {}
    
    private uint _questid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"questid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint questid
    {
      get { return _questid; }
      set { _questid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReturnQuestDetailInfoQuestUserCmd_S")]
  public partial class ReturnQuestDetailInfoQuestUserCmd_S : global::ProtoBuf.IExtensible
  {
    public ReturnQuestDetailInfoQuestUserCmd_S() {}
    
    private Cmd.SaveQuest _squest;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"squest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.SaveQuest squest
    {
      get { return _squest; }
      set { _squest = value; }
    }
    private Cmd.QuestProcess _process;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"process", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Cmd.QuestProcess process
    {
      get { return _process; }
      set { _process = value; }
    }
    private uint _npcbaseid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"npcbaseid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint npcbaseid
    {
      get { return _npcbaseid; }
      set { _npcbaseid = value; }
    }
    private string _detail;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"detail", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string detail
    {
      get { return _detail; }
      set { _detail = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OpenStageDialogQuestUserCmd_S")]
  public partial class OpenStageDialogQuestUserCmd_S : global::ProtoBuf.IExtensible
  {
    public OpenStageDialogQuestUserCmd_S() {}
    
    private uint _sectionid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"sectionid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint sectionid
    {
      get { return _sectionid; }
      set { _sectionid = value; }
    }
    private uint _stageid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"stageid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint stageid
    {
      get { return _stageid; }
      set { _stageid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestOpenStageQuestUserCmd_C")]
  public partial class RequestOpenStageQuestUserCmd_C : global::ProtoBuf.IExtensible
  {
    public RequestOpenStageQuestUserCmd_C() {}
    
    private uint _stageid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"stageid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint stageid
    {
      get { return _stageid; }
      set { _stageid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReturnOpenStageQuestUserCmd_S")]
  public partial class ReturnOpenStageQuestUserCmd_S : global::ProtoBuf.IExtensible
  {
    public ReturnOpenStageQuestUserCmd_S() {}
    
    private uint _stageid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"stageid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint stageid
    {
      get { return _stageid; }
      set { _stageid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PrepairFinishStageQuestUserCmd_S")]
  public partial class PrepairFinishStageQuestUserCmd_S : global::ProtoBuf.IExtensible
  {
    public PrepairFinishStageQuestUserCmd_S() {}
    
    private uint _stageid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"stageid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint stageid
    {
      get { return _stageid; }
      set { _stageid = value; }
    }
    private bool _result;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool result
    {
      get { return _result; }
      set { _result = value; }
    }
    private string _desc = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestFinishStageQuestUserCmd_C")]
  public partial class RequestFinishStageQuestUserCmd_C : global::ProtoBuf.IExtensible
  {
    public RequestFinishStageQuestUserCmd_C() {}
    
    private uint _stageid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"stageid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint stageid
    {
      get { return _stageid; }
      set { _stageid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"ClickQuestTaceEvent")]
    public enum ClickQuestTaceEvent
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClickQuestTaceEvent_None", Value=0)]
      ClickQuestTaceEvent_None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClickQuestTaceEvent_GoToNpc", Value=1)]
      ClickQuestTaceEvent_GoToNpc = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClickQuestTaceEvent_GoToPositon", Value=2)]
      ClickQuestTaceEvent_GoToPositon = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClickQuestTaceEvent_OpenDialog", Value=3)]
      ClickQuestTaceEvent_OpenDialog = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClickQuestTaceEvent_AttackMonster", Value=4)]
      ClickQuestTaceEvent_AttackMonster = 4
    }
  
}