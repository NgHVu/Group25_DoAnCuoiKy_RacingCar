using System.Collections.Generic;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace RacingCar_Client
{
    public class Player2 : RaceCar
    {
        private readonly Dictionary<Keys, bool> keyStates = new Dictionary<Keys, bool>();
        public Size Size { get; set; }
        public Player2()
        {
            // Khởi tạo trạng thái ban đầu của tất cả các phím là false
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                keyStates[key] = false;
            }
        }

        public override void ProcessInput(float dt)
        {
            // Xử lý phím bàn phím được nhấn
            PointF inputDirection = PointF.Empty;

            if (keyStates[Keys.Up])
                inputDirection.Y -= 1f; // Đi lên
            if (keyStates[Keys.Down])
                inputDirection.Y += 1f; // Đi xuống
            if (keyStates[Keys.Left])
                inputDirection.X -= 1f; // Sang trái
            if (keyStates[Keys.Right])
                inputDirection.X += 1f; // Sang phải
            if (!keyStates[Keys.Left] && !keyStates[Keys.Right])
                CurrentTurnAxis = 0f;
            
            // Nếu hướng di chuyển khác (0, 0), thực hiện chuyển đổi hướng từ tương đối sang thế giới
             if (inputDirection != PointF.Empty)
              {
                  inputDirection = new PointF(Right.X * inputDirection.X + Forward.X * inputDirection.Y,
                                               Right.Y * inputDirection.X + Forward.Y * inputDirection.Y);
              }

            // Xác định trạng thái phanh từ trạng thái bàn phím
            IsBraking = keyStates[Keys.D0];
            Move(dt, inputDirection);
        }

        // Sự kiện KeyDown và KeyUp được gán vào các phím tương ứng
        public void SetKeyDown(Keys key)
        {
            keyStates[key] = true;
        }

        public void SetKeyUp(Keys key)
        {
            keyStates[key] = false;
        }
        public void AttachInputEvents(Control control)
        {
            // Gắn sự kiện KeyDown của Control
            control.KeyDown += (sender, e) => SetKeyDown(e.KeyCode);

            // Gắn sự kiện KeyUp của Control
            control.KeyUp += (sender, e) => SetKeyUp(e.KeyCode);
        }
    }
}
