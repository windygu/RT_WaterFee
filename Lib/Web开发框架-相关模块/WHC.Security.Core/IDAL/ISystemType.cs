﻿using WHC.Security.Entity;
using WHC.Framework.ControlUtil;

namespace WHC.Security.IDAL
{
    public interface ISystemType : IBaseDAL<SystemTypeInfo>
	{
		SystemTypeInfo FindByOID(string oid);
		bool VerifySystem(string serialNumber, string typeID, int authorizeAmount);
	}
}