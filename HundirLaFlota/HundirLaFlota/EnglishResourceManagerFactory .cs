﻿using System.Reflection;


namespace HundirLaFlota
{
    internal class EnglishResourceManagerFactory : IResourceManagerFactory
    {
        public System.Resources.ResourceManager CreateResourceManager()
        {
            return new System.Resources.ResourceManager("HundirLaFlota.Resources.Resource_en", Assembly.GetExecutingAssembly());
        }
    }
}
