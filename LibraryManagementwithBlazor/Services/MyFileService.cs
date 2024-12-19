namespace LibraryManagementwithBlazor.Services
{
    public class MyFileService
    {
        public async Task SaveFileAsync(string fileName, Stream fileStream)
        {
            var uploadsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
            if (!Directory.Exists(uploadsDirectory))
            {
                Directory.CreateDirectory(uploadsDirectory);
            }

            var filePath = Path.Combine(uploadsDirectory, fileName);

            using var file = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            await fileStream.CopyToAsync(file);
        }

    }

}
