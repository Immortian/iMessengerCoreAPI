namespace iMessengerCoreAPI.Tests
{
    public class GetDialogTests
    {
        [Fact]
        public void GetDialogTest()
        {
            RGDialogsClients model = new RGDialogsClients();

            Assert.Equal<Guid>(new Guid("fcd6b112-1834-4420-bee6-70c9776f6378"), model.GetDialog(new List<Guid>
            {
                new Guid("4b6a6b9a-2303-402a-9970-6e71f4a47151"),
                new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820"),
                new Guid("7de3299b-2796-4982-a85b-2d6d1326396e")
            }));
            Assert.Equal<Guid>(new Guid("19f6f751-7f8d-41fa-8261-709028650592"), model.GetDialog(new List<Guid>
            {
                new Guid("4b6a6b9a-2303-402a-9970-6e71f4a47151"),
                new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820")
            }));
            Assert.Equal<Guid>(new Guid("83ebeb2b-c315-48a2-b6e5-f0324de57a9f"), model.GetDialog(new List<Guid>
            {
                new Guid("7de3299b-2796-4982-a85b-2d6d1326396e"),
                new Guid("0a58955e-342f-4095-88c6-1109d0f70583"),
                new Guid("50454d55-a73c-4cbc-be25-3c5729dcb82b")
            }));
        }

        [Fact]
        public void GetDialogListTest()
        {
            RGDialogsClients model = new RGDialogsClients();

            Assert.Equal<List<Guid>>(new List<Guid> { 
                new Guid("fcd6b112-1834-4420-bee6-70c9776f6378"), 
                new Guid("19f6f751-7f8d-41fa-8261-709028650592"),  
            }, model.GetDialogList(new List<Guid>
            {
                new Guid("4b6a6b9a-2303-402a-9970-6e71f4a47151"),
                new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820")
            }));
        }
    }
}