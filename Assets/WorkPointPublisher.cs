using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class WorkPointPublisher : Publisher<Messages.WorkPoint>
    {
        public Transform PublishedTransform;
        public string FrameId = "Unity";
        int a, b;

        private Messages.WorkPoint message;

        protected override void Start()
        {
            base.Start();
            InitializeMessage();
        }

        private void FixedUpdate()
        {
            UpdateMessage();
        }

        private void InitializeMessage()
        {
            message = new Messages.WorkPoint
            {
                header = new Messages.Standard.Header()
                {
                    frame_id = FrameId
                }
            };
            
        }
        

        private void UpdateMessage()
        {
            message.header.Update();
            message.grasp.position = GetGeometryPoint();
            message.grasp.orientation = GetGeometryQuaternion();
            message.assemble.position = GetGeometryPoint2();
            message.assemble.orientation = GetGeometryQuaternion2();

            if (OVRInput.GetDown(OVRInput.RawButton.X))
            {

                b = 0;

            }

            if (OVRInput.Get(OVRInput.RawButton.X) && a < 2)
            {
                a += 1;
                if (a < 2)
                    return;
                Publish(message);

            }

            if (OVRInput.GetUp(OVRInput.RawButton.X) && b == 0)
            {
                a = 0;
                Publish(message);
                b += 1;
            }
        }

        private Messages.Geometry.Point GetGeometryPoint()
        {
            Messages.Geometry.Point geometryPoint = new Messages.Geometry.Point();
            geometryPoint.x = CubeTukamuman.TerceroLocalPos.z;
            geometryPoint.y = -CubeTukamuman.TerceroLocalPos.x;
            geometryPoint.z = CubeTukamuman.TerceroLocalPos.y;
            return geometryPoint;
        }

        private Messages.Geometry.Quaternion GetGeometryQuaternion()
        {
            Messages.Geometry.Quaternion geometryQuaternion = new Messages.Geometry.Quaternion();
            geometryQuaternion.x = -CubeTukamuman.TerceroLocalRot.y;
            geometryQuaternion.y = CubeTukamuman.TerceroLocalRot.z;
            geometryQuaternion.z = CubeTukamuman.TerceroLocalRot.x;
            geometryQuaternion.w = -CubeTukamuman.TerceroLocalRot.w;
            return geometryQuaternion;
        }

        private Messages.Geometry.Point GetGeometryPoint2()
        {
            Messages.Geometry.Point geometryPoint = new Messages.Geometry.Point();
            geometryPoint.x = GetLocalPosition.localpos.z;
            geometryPoint.y = -GetLocalPosition.localpos.x;
            geometryPoint.z = GetLocalPosition.localpos.y;
            return geometryPoint;
        }

        private Messages.Geometry.Quaternion GetGeometryQuaternion2()
        {
            Messages.Geometry.Quaternion geometryQuaternion = new Messages.Geometry.Quaternion();
            geometryQuaternion.x = -GetLocalPosition.localrot.y;
            geometryQuaternion.y = GetLocalPosition.localrot.z;
            geometryQuaternion.z = GetLocalPosition.localrot.x;
            geometryQuaternion.w = -GetLocalPosition.localrot.w;
            return geometryQuaternion;
        }

    }
}