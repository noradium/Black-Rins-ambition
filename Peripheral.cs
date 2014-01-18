
using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Input;

namespace ShootingApp
{
    public sealed class Peripheral
    {
        private static GamePadData _padData;
        private static Dictionary<GamePadButtons, float> _holdDic;

        /// <summary>
        /// タッチ情報リスト
        /// </summary>
        public static List<TouchData> TouchDataList { get; private set; }

        /// <summary>
        /// 左アナログ
        /// </summary>
        public static Vector2 AnalogLeft;

        /// <summary>
        /// 右アナログ
        /// </summary>
        public static Vector2 AnalogRight;


        /// <summary>
        /// 静的コンストラクタ
        /// </summary>
        static Peripheral()
        {
            _padData = GamePad.GetData(0);
            TouchDataList = new List<TouchData>();
            _holdDic = new Dictionary<GamePadButtons, float>();
            foreach (GamePadButtons btnType in Enum.GetValues(typeof (GamePadButtons)))
            {
                _holdDic.Add(btnType, 0);
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>インスタンス作成禁止</remarks>
        private Peripheral()
        {
        }

        /// <summary>
        /// 更新処理
        /// </summary>
        /// <remarks>(※1フレームに一度だけ呼び出すこと)</remarks>
        public static void Update(float dt)
        {
            // タッチ情報取得
            TouchDataList = Touch.GetData(0);

            // パッド情報取得
			_padData = GamePad.GetData(0);
			
			if(_padData.ButtonsDown != 0)
			{
				Console.WriteLine(_padData.ButtonsDown);
			}
			
            // アナログ
            AnalogLeft = new Vector2(_padData.AnalogLeftX, _padData.AnalogLeftY);
            AnalogRight = new Vector2(_padData.AnalogRightX, _padData.AnalogRightY);

            // 押したままの時間を計測
            foreach (GamePadButtons btnType in Enum.GetValues(typeof (GamePadButtons)))
            {
                if (Down(btnType))
                {
                    // 押したままのボタンがある場合は、経過時間を保存
                    _holdDic[btnType] += dt;
                }
                else
                {
                    // 上記以外のボタンについては0クリア
                    _holdDic[btnType] = 0;
                }
            }
        }

        /// <summary>
        /// 指定したボタンが押下状態かを返す
        /// </summary>
        public static bool Down(GamePadButtons button)
        {
			return (_padData.Buttons & button) != 0;
        }
		
		/// <summary>
        /// 指定したボタンが今回のフレームで押し込まれたかを返す
		/// </summary>
		public static bool Press(GamePadButtons button)
		{
			return _padData.ButtonsDown.HasFlag(button);
		}
		
        /// <summary>
        /// 指定したボタンが今回のフレームで離したかを返す
        /// </summary>
        public static bool Release(GamePadButtons button)
        {
            return _padData.ButtonsUp.HasFlag(button);
        }

        /// <summary>
        /// タッチ画面がタッチダウンされているかを返す
        /// </summary>
        public static bool TouchDown()
        {
            if (TouchDataList.Count > 0)
            {
                return TouchDataList[0].Status == TouchStatus.Down;
            }

            return false;
        }

        /// <summary>
        /// タッチ画面がタッチアップされているかを返す。
        /// </summary>
        public static bool TouchUp()
        {
            if (TouchDataList.Count > 0)
            {
                return TouchDataList[0].Status == TouchStatus.Up;
            }

            return false;
        }

        /// <summary>
        /// 指定したボタンが押下したままdt秒経過しているかどうかを返す
        /// </summary>
        public static bool IsHoldKey(GamePadButtons button, float dt)
        {
            if (!_holdDic.ContainsKey(button))
            {
                return false;
            }

            return _holdDic[button] > dt;
        }
    }
}

