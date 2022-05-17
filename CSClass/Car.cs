using System;

namespace CSClass
{
    internal class Car
    {
        int carnumber;  // 자동차 번호
        DateTime inTime;
        DateTime outTime;

        /// <summary>
        ///  자동차가 들어온 시간 설정
        /// </summary>

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        /// <summary>
        /// 자동차가 나간 시간 설정
        /// </summary>
        
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
}