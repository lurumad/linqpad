<Query Kind="Program" />

void Main()
{
	var targetsFilePath = @"C:\DEV\DEV_AR\SM.Edu.Core\SM.Edu.Core.Web\MinifyTasks\DatosCentro\Minify.DatosCentro.targets";
	
	var xml = XDocument.Load(targetsFilePath);

	var targets = xml.Elements().Elements().Skip(1);
	
	var bundles =
		from target in targets
		select new
		{
			VirtualPath = target
				.Attribute("Name").Value,
			VirtualPaths = target
				.Elements()
				.First()
				.Elements()
				.Select(t => t.Attribute("Include").Value.Replace(@"\", "/").Replace("$(ProjectDir)", "~/")),
			CdnPath = target
				.Elements()
				.First(t => t.Name.LocalName == "JavaScriptCompressorTask")
				.Attribute("OutputFile").Value.Replace(@"\", "/").Replace("$(ProjectDir)", "~/")
		};
		 
	bundles.Dump();
}

// Define other methods and classes here