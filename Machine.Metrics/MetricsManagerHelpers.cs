﻿using Mnemox.Machine.Metrics.Windows;
using System;
using System.Runtime.InteropServices;

namespace Mnemox.Machine.Metrics
{
    public class MetricsManagerHelpers : IMetricsManagerHelpers
    {
        public OSPlatform DetectOsPlatform()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return OSPlatform.Windows;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                throw new NotImplementedException();
            }

            throw new NotImplementedException("Not supported platform");
        }

        public IMemoryMetrics GetMemoryMetricsCollector(OSPlatform osPlatform)
        {
            if (osPlatform == OSPlatform.Windows)
            {
                return new WindowsMemoryMetrics();
            }
            else if (osPlatform == OSPlatform.Linux)
            {
                throw new NotImplementedException();
            }

            throw new PlatformNotSupportedException($"Not supported platform {osPlatform}");
        }

        public ICpuMetrics GetCpuMetricsCollector(OSPlatform osPlatform)
        {
            if (osPlatform == OSPlatform.Windows)
            {
                return new WindowsCpuMetrics();
            }
            else if (osPlatform == OSPlatform.Linux)
            {
                throw new NotImplementedException();
            }

            throw new PlatformNotSupportedException($"Not supported platform {osPlatform}");
        }
    }
}
