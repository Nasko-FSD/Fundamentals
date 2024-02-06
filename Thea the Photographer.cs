ulong totalPictures = ulong.Parse(Console.ReadLine());
ulong filterTime = ulong.Parse(Console.ReadLine());
ulong filterPercentage = ulong.Parse(Console.ReadLine());
ulong uploadSeconds = ulong.Parse(Console.ReadLine());

ulong totalPicturesFilterTime = totalPictures * filterTime;
ulong restPictures = (ulong)Math.Ceiling((filterPercentage / 100.0) * totalPictures);
ulong uploadTime = restPictures * uploadSeconds;
ulong totalSeconds = uploadTime + totalPicturesFilterTime;

TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
string totalTime = time.ToString(@"d\:hh\:mm\:ss");
Console.WriteLine(totalTime);