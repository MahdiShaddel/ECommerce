namespace ECommerce.InfraStructure.Configuration
{
    public static class ConfigureContainer
    {
        public static void UseSwaggerConfig(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Core Api"));
        }
    }
}
