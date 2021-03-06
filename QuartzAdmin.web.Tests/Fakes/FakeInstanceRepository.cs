﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuartzAdmin.web.Models;

namespace QuartzAdmin.web.Tests.Fakes
{
    public class FakeInstanceRepository : IInstanceRepository
    {
        #region IInstanceRepository Members

        List<QuartzAdmin.web.Models.InstanceModel> _instances = new List<QuartzAdmin.web.Models.InstanceModel>();

        public void Delete(QuartzAdmin.web.Models.InstanceModel instance)
        {
            _instances.Remove(instance);
        }

        public void Save(QuartzAdmin.web.Models.InstanceModel instance)
        {
            //throw new NotImplementedException();
            _instances.Add(instance);
            QuartzAdmin.web.Models.InstanceModel found = _instances.Find(x => x.InstanceName == instance.InstanceName);
            if (found != null)
            {
                _instances.Remove(found);
            }
            _instances.Add(instance);
        }

        public QuartzAdmin.web.Models.InstanceModel GetByName(string name)
        {
            //throw new NotImplementedException();

            return _instances.Where(x => x.InstanceName == name).FirstOrDefault();
        }


        public List<QuartzAdmin.web.Models.InstanceModel> GetAll()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
