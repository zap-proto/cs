using BenchmarkDotNet.Running;
using Zap.Rpc;
using Grpc.Net.Client;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || args[0] == "grpc")
                BenchmarkRunner.Run<GrpcBenchmark>();

            if (args.Length == 0 || args[0] == "zap")
                BenchmarkRunner.Run<ZapBenchmark>();
        }
    }
}
