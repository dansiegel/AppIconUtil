using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AppLogoUtil.Generators
{
    public class IconGeneratorCollection : IEnumerable<IPlatformIconGenerator>
    {
        Dictionary<Platform, IPlatformIconGenerator> _generators { get; }

        public IconGeneratorCollection()
        {
            _generators = new Dictionary<Platform, IPlatformIconGenerator>();
        }

        public IPlatformIconGenerator this[Platform key]
        {
            get
            {
                if (_generators.ContainsKey(key))
                    return _generators[key];

                return _generators[key] = PlatformGeneratorFactory.GetGenerator(key);
            }
        }

        public IEnumerator<IPlatformIconGenerator> GetEnumerator() =>
            _generators.Select(d => d.Value).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() =>
            this.GetEnumerator();
    }
}
