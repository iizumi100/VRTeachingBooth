/*
This message class is generated automatically with 'ServiceMessageGenerator' of ROS#
*/ 

using Newtonsoft.Json;
using RosSharp.RosBridgeClient.Messages.Geometry;
using RosSharp.RosBridgeClient.Messages.Navigation;
using RosSharp.RosBridgeClient.Messages.Sensor;
using RosSharp.RosBridgeClient.Messages.Standard;
using RosSharp.RosBridgeClient.Messages.Actionlib;

namespace RosSharp.RosBridgeClient.Services
{
public class ServiceWakaranRequest : Message
{
[JsonIgnore]
public const string RosMessageName = "unity_test_srvs/ServiceWakaran";

public Pose reqtest;

//public ServiceWakaranRequest(Pose _reqtest){reqtest = _reqtest;
//}
}

public class ServiceWakaranResponse : Message
{
[JsonIgnore]
public const string RosMessageName = "unity_test_srvs/ServiceWakaran";


        public Pose aaa;
        public int bbb;
       

        public ServiceWakaranResponse(Pose aaa, int bbb)
        {
            this.aaa = aaa;
            this.bbb = bbb;
        }
    }
}

