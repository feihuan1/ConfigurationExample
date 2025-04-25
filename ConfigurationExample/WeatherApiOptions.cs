/* option pattern  */
// option pattern uses custom classes to specify what configuration settings are to be loaded into properties
//exp: reading the specific connections strings out of many configuration settings.

// the option class should be a non-abstract class with a public parameterless constructor.
// public read-write properties are bound
// fields are not bound.

namespace ConfigurationExample
{
    public class WeatherApiOptions
    {
        public string? ClientId { get; set; }
        public string? ClientSecret { get; set; }
    }
}
