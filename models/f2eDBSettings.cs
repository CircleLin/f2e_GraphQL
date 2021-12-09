namespace f2e_GraphQL.models
{
    public class f2eDBSettings : If2eDBSettings
    {
        public string? f2eCollectionName { get; set; }
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
    }
}
