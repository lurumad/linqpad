<Query Kind="Program" />

void Main()
{
	var area1 = new AreaInfo() { Name = "DatosCentro" };
	var area2 = new AreaInfo() { Name = "DatosCentro" };
	
	HashSet<AreaInfo> areas = new HashSet<AreaInfo>(new AreaInfoEqualityComparer());
	areas.Add(area1);
	
	if (areas.Contains(area2))
	{
		Debug.Write("Contains!");
	}
	else
	{
		Debug.Write("Not contains!");
	}
}

class AreaInfo
{
	public string Name { get; set; }
}

class AreaInfoEqualityComparer : IEqualityComparer<AreaInfo>
{
	public bool Equals(AreaInfo areaInfo1, AreaInfo areaInfo2)
	{
		if (String.Compare(areaInfo1.Name, areaInfo2.Name, true) == 0)
		{
			return true;
		}
		
		return false;
	}
	
	public int GetHashCode(AreaInfo areaInfo)
	{
		return 1;
	}
}