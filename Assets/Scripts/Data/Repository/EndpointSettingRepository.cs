﻿using System.Collections.Generic;
using ProjectBlue.RepulserEngine.DataStore;
using ProjectBlue.RepulserEngine.Domain.Model;

namespace ProjectBlue.RepulserEngine.Repository
{
    public class EndpointSettingRepository : IEndpointSettingRepository
    {

        private IEndpointSettingDataStore endpointSettingDataStore;
        
        public EndpointSettingRepository(IEndpointSettingDataStore endpointSettingDataStore)
        {
            this.endpointSettingDataStore = endpointSettingDataStore;
        }

        public void Save(IEnumerable<EndpointSetting> endpointSettingList)
        {
            endpointSettingDataStore.Save(endpointSettingList);
        }

        public IEnumerable<EndpointSetting> Load()
        {
            return endpointSettingDataStore.Load();
        }
    }

}

