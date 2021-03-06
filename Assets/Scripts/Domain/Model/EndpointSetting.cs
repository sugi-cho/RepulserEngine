﻿using System;
using System.Net;
using UnityEngine;

namespace ProjectBlue.RepulserEngine.Domain.Model
{
    
    [Serializable]
    public class EndpointSetting
    {

        [SerializeField] private string ip;
        [SerializeField] private int port;
        [SerializeField] private string endpointName;
        [SerializeField] private int offsetFrame;

        public IPEndPoint EndPoint => new IPEndPoint(IPAddress.Parse(ip), port);
        public string EndPointName => endpointName;
        public int OffsetFrame => offsetFrame;
        
        
    
        public EndpointSetting(IPEndPoint endPoint, string endPointName, int offsetFrame)
        {
            this.endpointName = endPointName;
            this.offsetFrame = offsetFrame;

            ip = endPoint.Address.ToString();
            port = endPoint.Port;
        }

        public void UpdateData(IPEndPoint endPoint, string endPointName, int offsetFrame)
        {
            this.endpointName = endPointName;
            this.offsetFrame = offsetFrame;
            
            ip = endPoint.Address.ToString();
            port = endPoint.Port;
        }
    }

}