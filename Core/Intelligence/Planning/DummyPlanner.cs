using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSLRig.Core.Common;
using SSLRig.Core.Data.Packet;
using SSLRig.Core.Interface;

namespace SSLRig.Core.Intelligence.Planning
{
    /// <summary>
    /// A dummy planner to perform fixed tasks
    /// </summary>
    public class DummyPlanner : IPlanner, ITask, IDataSource
    {
        protected IRepository repo;
        protected GetNextTasks getNextTasks;
        protected SSL_Referee refereeCommand;

        public IRepository Repository
        {
            get { return repo; }
            set { repo = value; }
        }

        public void Initialize()
        {
        }

        public void Plan()
        {
            FollowOpponent();
        }

        public IRobotInfo[] PlanExclusive(Data.Packet.SSL_WrapperPacket mainPacket)
        {
            return null;
        }

        public void Release()
        {
            
        }
        
        public Common.GetNextTasks GetNext
        {
            get { return getNextTasks; }
            set { getNextTasks = value; }
        }

        public void Execute()
        {
            Plan();
        }


        public void OnRefereeCommandChanged(Data.Packet.SSL_Referee command)
        {
            refereeCommand = command;
        }

        #region Behaviors

        public void FollowOpponent()
        {
            foreach (var robot in repo.InData.Opponent())
            {
                if (robot != null)
                {
                    repo.OutData[(int) robot.robot_id].SetPoint(robot.x, robot.y, robot.orientation);
                }
            }
        }
        #endregion
    }
}
