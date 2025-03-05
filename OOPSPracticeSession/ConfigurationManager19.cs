using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public class ConfigurationManager19
    {
        private static ConfigurationManager19 _instance = null;

    // Step 2: Lock object for thread safety
    private static readonly object _lock = new object();

    // Step 3: Private constructor to prevent direct instantiation
    private ConfigurationManager19()
    {
        Console.WriteLine("ConfigurationManager Instance Created.");
    }

    // Step 4: Public static method to return the single instance (Thread-Safe)
    public static ConfigurationManager19 GetInstance()
    {
        if (_instance == null) // First check (no locking)
        {
            lock (_lock) // Thread synchronization
            {
                if (_instance == null) // Second check (after acquiring lock)
                {
                    _instance = new ConfigurationManager19();
                }
            }
        }
        return _instance;
    }

    // Example method to get configuration values
    public void ShowConfiguration()
    {
        Console.WriteLine("Configuration settings loaded.");
    }

    }
}
