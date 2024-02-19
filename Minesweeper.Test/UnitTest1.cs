namespace Minesweeper.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE
            var model = new Model(100);

            //ACT
            model.DoTurn("C2");

            //ASSERT
            //-> Prüfung Spielzustand
        }
    }
}