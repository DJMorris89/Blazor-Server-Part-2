﻿using Microsoft.Extensions.Logging;

namespace BlazorApp.Data
{
    public class CounterService : ICounterService
    {
        private readonly ILogger<CounterService> _log;

        public int CounterValue { get; set; }

        public CounterService(ILogger<CounterService> log)
        {
            _log = log;
        }

        public void IncrementCounter()
        {
            CounterValue += 1;
            _log.LogInformation("The counter was incremented to {CounterValue}", CounterValue);
        }
    }
}
