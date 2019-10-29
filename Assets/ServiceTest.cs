using UnityEngine;
using System.Collections.Generic;
using RosSharp.RosBridgeClient.Services.FileServer;
using RosSharp.RosBridgeClient.Services.RosApi;
using RosSharp.RosBridgeClient.Services.Standard;
using RosSharp.RosBridgeClient.Services;

namespace RosSharp.RosBridgeClient
{
    public class ServiceTest : ServiceProvider<Services.ServiceWakaranRequest, Services.ServiceWakaranResponse>
    {
        public Transform PublishedTransform;
        public string FrameId = "Unity";

        
        private Services.ServiceWakaranResponse message;
        private Messages.Geometry.Pose aaa;
        private int bbb;

        protected override void Start()
        {
            base.Start();
            aaa = new Messages.Geometry.Pose();
            bbb = new int();
            
        }

        /*private void FixedUpdate()
        {
            UpdateMessage();
        }*/


        /*private void Update()
        {
           
            message.restest.position = GetGeometryPoint(PublishedTransform.position.Unity2Ros());
            message.restest.orientation = GetGeometryQuaternion(PublishedTransform.rotation.Unity2Ros());

            //Publish(message);
        }*/

        private void Update()
        {

            //message.restest.position = GetGeometryPoint(PublishedTransform.position.Unity2Ros());
            //message.restest.orientation = GetGeometryQuaternion(PublishedTransform.rotation.Unity2Ros());
            aaa.position = GetGeometryPoint(PublishedTransform.position.Unity2Ros());
            aaa.orientation = GetGeometryQuaternion(PublishedTransform.rotation.Unity2Ros());
            bbb = 15;
        }

        private Messages.Geometry.Point GetGeometryPoint(Vector3 position)
        {
            Messages.Geometry.Point geometryPoint = new Messages.Geometry.Point();
            geometryPoint.x = position.x;
            geometryPoint.y = position.y;
            geometryPoint.z = position.z;
            return geometryPoint;
        }

        private Messages.Geometry.Quaternion GetGeometryQuaternion(Quaternion quaternion)
        {
            Messages.Geometry.Quaternion geometryQuaternion = new Messages.Geometry.Quaternion();
            geometryQuaternion.x = quaternion.x;
            geometryQuaternion.y = quaternion.y;
            geometryQuaternion.z = quaternion.z;
            geometryQuaternion.w = quaternion.w;
            return geometryQuaternion;
        }

        protected override bool ServiceCallHandler(ServiceWakaranRequest request, out ServiceWakaranResponse response)
        {
            response = new ServiceWakaranResponse(aaa,bbb);
            return true;
        }
    }
}