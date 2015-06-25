//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: referee.proto
namespace SSLRig.Core.Data.Packet
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SSL_Referee")]
  public partial class SSL_Referee : global::ProtoBuf.IExtensible
  {
    public SSL_Referee() {}
    
    private ulong _packet_timestamp;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"packet_timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong packet_timestamp
    {
      get { return _packet_timestamp; }
      set { _packet_timestamp = value; }
    }
    private SSL_Referee.Stage _stage;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"stage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public SSL_Referee.Stage stage
    {
      get { return _stage; }
      set { _stage = value; }
    }

    private int _stage_time_left = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"stage_time_left", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int stage_time_left
    {
      get { return _stage_time_left; }
      set { _stage_time_left = value; }
    }
    private SSL_Referee.Command _command;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"command", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public SSL_Referee.Command command
    {
      get { return _command; }
      set { _command = value; }
    }
    private uint _command_counter;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"command_counter", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint command_counter
    {
      get { return _command_counter; }
      set { _command_counter = value; }
    }
    private ulong _command_timestamp;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"command_timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong command_timestamp
    {
      get { return _command_timestamp; }
      set { _command_timestamp = value; }
    }
    private SSL_Referee.TeamInfo _yellow;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"yellow", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public SSL_Referee.TeamInfo yellow
    {
      get { return _yellow; }
      set { _yellow = value; }
    }
    private SSL_Referee.TeamInfo _blue;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"blue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public SSL_Referee.TeamInfo blue
    {
      get { return _blue; }
      set { _blue = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamInfo")]
  public partial class TeamInfo : global::ProtoBuf.IExtensible
  {
    public TeamInfo() {}
    
    private string _name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private uint _score;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"score", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint score
    {
      get { return _score; }
      set { _score = value; }
    }
    private uint _red_cards;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"red_cards", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint red_cards
    {
      get { return _red_cards; }
      set { _red_cards = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _yellow_card_times = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"yellow_card_times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<uint> yellow_card_times
    {
      get { return _yellow_card_times; }
    }
  
    private uint _yellow_cards;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"yellow_cards", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint yellow_cards
    {
      get { return _yellow_cards; }
      set { _yellow_cards = value; }
    }
    private uint _timeouts;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"timeouts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint timeouts
    {
      get { return _timeouts; }
      set { _timeouts = value; }
    }
    private uint _timeout_time;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"timeout_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint timeout_time
    {
      get { return _timeout_time; }
      set { _timeout_time = value; }
    }
    private uint _goalie;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"goalie", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint goalie
    {
      get { return _goalie; }
      set { _goalie = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"Stage")]
    public enum Stage
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NORMAL_FIRST_HALF_PRE", Value=0)]
      NORMAL_FIRST_HALF_PRE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NORMAL_FIRST_HALF", Value=1)]
      NORMAL_FIRST_HALF = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NORMAL_HALF_TIME", Value=2)]
      NORMAL_HALF_TIME = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NORMAL_SECOND_HALF_PRE", Value=3)]
      NORMAL_SECOND_HALF_PRE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NORMAL_SECOND_HALF", Value=4)]
      NORMAL_SECOND_HALF = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EXTRA_TIME_BREAK", Value=5)]
      EXTRA_TIME_BREAK = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EXTRA_FIRST_HALF_PRE", Value=6)]
      EXTRA_FIRST_HALF_PRE = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EXTRA_FIRST_HALF", Value=7)]
      EXTRA_FIRST_HALF = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EXTRA_HALF_TIME", Value=8)]
      EXTRA_HALF_TIME = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EXTRA_SECOND_HALF_PRE", Value=9)]
      EXTRA_SECOND_HALF_PRE = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EXTRA_SECOND_HALF", Value=10)]
      EXTRA_SECOND_HALF = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PENALTY_SHOOTOUT_BREAK", Value=11)]
      PENALTY_SHOOTOUT_BREAK = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PENALTY_SHOOTOUT", Value=12)]
      PENALTY_SHOOTOUT = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"POST_GAME", Value=13)]
      POST_GAME = 13
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"Command")]
    public enum Command
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"HALT", Value=0)]
      HALT = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"STOP", Value=1)]
      STOP = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NORMAL_START", Value=2)]
      NORMAL_START = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FORCE_START", Value=3)]
      FORCE_START = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PREPARE_KICKOFF_YELLOW", Value=4)]
      PREPARE_KICKOFF_YELLOW = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PREPARE_KICKOFF_BLUE", Value=5)]
      PREPARE_KICKOFF_BLUE = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PREPARE_PENALTY_YELLOW", Value=6)]
      PREPARE_PENALTY_YELLOW = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PREPARE_PENALTY_BLUE", Value=7)]
      PREPARE_PENALTY_BLUE = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DIRECT_FREE_YELLOW", Value=8)]
      DIRECT_FREE_YELLOW = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DIRECT_FREE_BLUE", Value=9)]
      DIRECT_FREE_BLUE = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INDIRECT_FREE_YELLOW", Value=10)]
      INDIRECT_FREE_YELLOW = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INDIRECT_FREE_BLUE", Value=11)]
      INDIRECT_FREE_BLUE = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TIMEOUT_YELLOW", Value=12)]
      TIMEOUT_YELLOW = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TIMEOUT_BLUE", Value=13)]
      TIMEOUT_BLUE = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GOAL_YELLOW", Value=14)]
      GOAL_YELLOW = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GOAL_BLUE", Value=15)]
      GOAL_BLUE = 15
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
