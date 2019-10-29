/*
This message class is generated automatically with 'SimpleMessageGenerator' of ROS#
*/ 

using Newtonsoft.Json;
using RosSharp.RosBridgeClient.Messages.Geometry;
//using RosSharp.RosBridgeClient.Messages.Navigadetion;
using RosSharp.RosBridgeClient.Messages.Sensor;
using RosSharp.RosBridgeClient.Messages.Standard;
using RosSharp.RosBridgeClient.Messages.Actionlib;

namespace RosSharp.RosBridgeClient.Messages
{
public class WorkPoint : Message
{
[JsonIgnore]
public const string RosMessageName = "denso_state_msgs/WorkPoint";

public Header header;
public Pose grasp;
public Pose assemble;

public WorkPoint()
{
header = new Header();
grasp = new Pose();
assemble = new Pose();
}
}
}

