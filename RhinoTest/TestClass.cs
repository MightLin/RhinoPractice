namespace RhinoTest
{
	public class TestClass
	{
		private readonly IInject _inject;

		public TestClass(IInject inject)
		{
			_inject = inject;
		}

		public string ToUpper(string name)
		{
			return _inject.ToUpper(name);
		}

		public void ReturnVoid(string name)
		{
			_inject.ReturnVoid(name);
		}
	}
}