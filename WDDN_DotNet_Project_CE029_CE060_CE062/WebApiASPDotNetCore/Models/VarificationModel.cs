using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebApi.Models
{
    public class VarificationModel
    {
        private EntityEntry<UserModelTemp> tempUser;
        private int code;
        private DateTime now;

        public VarificationModel() { }
        public VarificationModel(UserModelTemp user, int code, DateTime time)
        {
            this.User = user;
            this.VarificationCode = code;
            this.CreateDate = time;
        }

        public VarificationModel(EntityEntry<UserModelTemp> tempUser, int code, DateTime now)
        {
            this.tempUser = tempUser;
            this.code = code;
            this.now = now;
        }

        public int Id { get; set; }
        public UserModelTemp User { get; set; }
        public int VarificationCode { get; set; }
        public DateTime CreateDate { get; set; }

    }
}