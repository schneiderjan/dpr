using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DprIteratorPattern
{
    public class ChannelRepository : IContainer
    {
        //public static string[] Names = new[] { "One", "Two", "Three", "Li", "Li" };
        public static Channel[] Channels = new[]
        {
            new Channel("ARD"),
            new Channel("ZDF"),
            new Channel("WDR"),
            new Channel("TVR"),
            new Channel("PRO TV"),
            new Channel("DIGI Sport"),
            new Channel("Dolce Sport"),
            new Channel("SPORT1"),
            new Channel("Acasa TV"),

        };

        public IIterator GetIterator()
        {
            return new ChannelIterator();
        }

        private class ChannelIterator : IIterator
        {

            private int _index = -1;
            public bool HasNext()
            {
                if (_index < Channels.Length - 1 || _index == -1) return true;
                return false;
            }

            public bool HasPrevious()
            {
                if (_index > 0) return true;
                return false;
            }

            public object Next()
            {
                if (HasNext())
                {
                    _index++;
                    return Channels[_index];
                }
                return null;
            }

            public object Previous()
            {
                if (HasPrevious())
                {
                    _index--;
                    return Channels[_index];
                }
                return null;
            }
        }
    }
}
