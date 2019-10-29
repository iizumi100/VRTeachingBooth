/*
This message class is generated automatically with 'SimpleMessageGenerator' of ROS#
*/ 

using Newtonsoft.Json;
using RosSharp.RosBridgeClient.Messages.Geometry;
using RosSharp.RosBridgeClient.Messages.Navigation;
using RosSharp.RosBridgeClient.Messages.Sensor;
using RosSharp.RosBridgeClient.Messages.Standard;
using RosSharp.RosBridgeClient.Messages.Actionlib;

namespace RosSharp.RosBridgeClient.Messages
{
public class PoseStampedPrimitive : Message
{
[JsonIgnore]
public const string RosMessageName = "beginner_tutorials/PoseStampedPrimitive";

public Header header;
public Pose pose;
public int primitive;

public PoseStampedPrimitive()
{
header = new Header();
pose = new Pose();
primitive = new int();
}
}
}

