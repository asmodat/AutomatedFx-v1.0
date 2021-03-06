﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using System.Diagnostics;
using System.Reflection;

using System.Linq.Expressions;

using System.Windows.Forms;

using System.Collections.Concurrent;

namespace Asmodat.Abbreviate
{
    public partial class ThreadedTimers : IDisposable
    {

        ThreadedMethod Threads = null;

        public bool Run(Expression<Action> EAMethod, int interval, int delay, string ID = null, bool Exceptions = true, bool waitForAccess = false)
        {
            if (System.String.IsNullOrEmpty(ID))
                ID = Expressions.nameofFull(EAMethod);

            if (Threads == null)
                Threads = new ThreadedMethod(this.MaxThreadsCount, ThreadPriority.Lowest, 1);


            Threads.Run(() => this.Run(EAMethod, interval, ID, Exceptions, waitForAccess), ID, delay, true, true, false);

            return false;
        }




        /// <summary>
        /// Autostarts timer
        /// </summary>
        /// <param name="EAMethod"></param>
        /// <param name="interval"></param>
        /// <param name="ID"></param>
        /// <param name="Exceptions"></param>
        /// <param name="waitForAccess"></param>
        /// <returns></returns>
        public bool Run(Expression<Action> EAMethod, int interval, string ID = null, bool Exceptions = true, bool waitForAccess = false)
        {
            if (EAMethod == null) return false;

            if (MaxThreadsCount < TDSTTimers.Count)
            {
                if (!waitForAccess) return false;

                while (MaxThreadsCount <= TDSTTimers.Count) Thread.Sleep(1);
            }


            if (System.String.IsNullOrEmpty(ID))
                ID = Expressions.nameofFull(EAMethod);

            ThreadedTimer TTimer = Timer(ID);

            if (TTimer != null && TTimer.Enabled)
                return false;

            TTimer = new ThreadedTimer(EAMethod, interval, true);

            TDSTTimers.Add(ID, TTimer);
            TDSTTimers[ID].Start();

            return true;


           // return this.Run(EAMethod, interval, ID, Exceptions, waitForAccess, true);
        }

        public bool Run(Expression<Action> EAMethod, int interval, string ID, bool Exceptions, bool waitForAccess, bool autostart)
        {
            if (EAMethod == null) return false;

            if (MaxThreadsCount < TDSTTimers.Count)
            {
                if (!waitForAccess) return false;

                while (MaxThreadsCount <= TDSTTimers.Count) Thread.Sleep(1);
            }


            if (System.String.IsNullOrEmpty(ID))
                ID = Expressions.nameofFull(EAMethod);

            ThreadedTimer TTimer = Timer(ID);

            if (TTimer != null && TTimer.Enabled)
                return false;

            TTimer = new ThreadedTimer(EAMethod, interval, autostart);

            TDSTTimers.Add(ID, TTimer);
            TDSTTimers[ID].Start();

            return true;
        }


    }
}
