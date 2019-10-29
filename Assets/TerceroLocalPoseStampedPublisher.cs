using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class TerceroLocalPoseStampedPublisher : Publisher<Messages.Geometry.PoseStamped>
    {
        public Transform PublishedTransform;
        public string FrameId = "Unity";

        private Messages.Geometry.PoseStamped message;

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
            message = new Messages.Geometry.PoseStamped
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
            message.pose.position = GetGeometryPoint();
            message.pose.orientation = GetGeometryQuaternion();

            Publish(message);
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

    }
}