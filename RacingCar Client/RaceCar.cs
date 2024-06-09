using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingCar_Client
{
    public class RaceCar
    {
        public string Name { get; set; } = "RaceCar";
        public float ForwardSpeed { get; set; } = 100f;
        public float BackwardSpeed { get; set; } = 50f;
        public float TurnSpeed { get; set; } = 30f;
        public float WheelTurnSpeed { get; set; } = 3f;
        public float AccelerationSpeed { get; set; } = 44f; //lùi
        public float DecelerationSpeed { get; set; } = 44.5f; //tiến
        public float MaxSpeed { get; set; } = 50f; // Đặt tốc độ cực đại 
        public float BrakeSpeed { get; set; } = 20f;
        public float CurrentThrottle { get; set; } = 0f;
        public float CurrentTurnAxis { get; set; } = 0f;
        public bool IsBraking { get; set; } = false;
        public PointF Position { get; set; } = new PointF(0, 0);
        public float Angle { get; set; } = 0f;
        public PointF Right => new PointF((float)Math.Cos((double)Angle + Math.PI / 2), (float)Math.Sin((double)Angle + Math.PI / 2));
        public PointF Forward => new PointF((float)Math.Cos((double)Angle), (float)Math.Sin((double)Angle));
        public Size Size { get; set; } // Thêm định nghĩa cho thuộc tính Size

       
        // Phương thức di chuyển của xe
        public void Move(float dt, PointF inputDirection)
        {
            // Lấy hướng di chuyển hiện tại của xe
            PointF dir = new PointF((float)Math.Cos((double)Angle), (float)Math.Sin((double)Angle));

            // Tính toán độ dốc của hướng di chuyển và hướng người dùng muốn di chuyển
            float dot = dir.X * inputDirection.X + dir.Y * inputDirection.Y;
            dot *= 0.5f;
            // Cập nhật góc quay của xe
            float turnAxisTarget = inputDirection.X * dir.Y - inputDirection.Y * dir.X;
            CurrentTurnAxis = MathUtils.Lerp(dt * WheelTurnSpeed, CurrentTurnAxis, turnAxisTarget);
            Angle += TurnSpeed * CurrentTurnAxis * CurrentThrottle * dt;

            // Chuyển đổi góc về khoảng [0, 2*pi)
            Angle %= (float)(Math.PI * 2);
            if (Angle < 0) Angle += (float)(Math.PI * 2); // Đảm bảo góc luôn dương

            // Clamp trục quay khi gần mục tiêu
            if (Math.Abs(CurrentTurnAxis - turnAxisTarget) <= 0.1f)
                CurrentTurnAxis = turnAxisTarget;

            // Tính toán gas và tốc độ
            float throttle = dot;

            // Nếu không nhấn phanh
            if (!IsBraking)
            {
                // Điều chỉnh tốc độ tăng/giảm
                float targetThrottle = throttle > 0 ? throttle * ForwardSpeed : throttle * BackwardSpeed;
                float speedDiff = targetThrottle - CurrentThrottle;
                float accel = speedDiff > 0 ? AccelerationSpeed : DecelerationSpeed;


                // Giới hạn tốc độ cực đại
                float maxThrottle = MaxSpeed / (throttle > 0 ? ForwardSpeed : BackwardSpeed);
                targetThrottle = Math.Min(targetThrottle, maxThrottle);
                CurrentThrottle = MathUtils.Approach(dt * accel, CurrentThrottle, targetThrottle);
            }
            else
            {
                // Phanh
                CurrentThrottle = MathUtils.Approach(dt * BrakeSpeed, CurrentThrottle, 0f);
                if (CurrentThrottle <= 0.01f)
                {
                    // Nếu đã dừng hoàn toàn, tắt phanh
                    IsBraking = false;
                }
            }

            // Tính toán vận tốc dựa trên gas và hướng di chuyển
              float speed = CurrentThrottle > 0 ? ForwardSpeed : BackwardSpeed;
              Position = new PointF(Position.X + dir.X * speed * CurrentThrottle * dt, Position.Y + dir.Y * speed * CurrentThrottle * dt);


        }
        public virtual void Stop(float dt)
        {
            // Đặt tốc độ hiện tại của xe về 0
            CurrentThrottle = MathUtils.Approach(dt * BrakeSpeed, CurrentThrottle, 0f);
        }
        public virtual void ProcessInput(float dt) { }



    }
}
