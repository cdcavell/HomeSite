namespace HomeSite.IdentiyServer4.Models.AppSettings
{
    /// <summary>
    /// Application model
    /// </summary>
    /// <revision>
    /// __Revisions:__~~
    /// | Contributor | Build | Revison Date | Description |~
    /// |-------------|-------|--------------|-------------|~
    /// | Christopher D. Cavell | 0.0.1 | 05/17/2020 | Initial build |~ 
    /// </revision>
    public class Application
    {
        /// <value>string</value>
      public string Name { get; set; }
        /// <value>string</value>
        public string Version { get; set; }
        /// <value>string</value>
        public string SecretKey { get; set; }
    }
}
