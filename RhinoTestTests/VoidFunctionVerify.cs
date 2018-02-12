using Microsoft.VisualStudio.TestTools.UnitTesting;
using RhinoTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Mocks;

namespace RhinoTest.Tests
{
	[TestClass()]
	public class VoidFunctionVerify
	{
		private const string input = "abc";


		[TestMethod()]
		public void void_驗證調用次數及參數_AssertWasCalled()
		{
			//arrange
			var inject = MockRepository.GenerateMock<IInject>();
			var test = new TestClass(inject);

			//action

			test.ReturnVoid(input);

			//assert

			inject.AssertWasCalled(
				mock => mock.ReturnVoid(Arg<string>.Is.Equal(input))
				, opt => opt.Repeat.Times(1)
			);

		}


		[TestMethod()]
		public void void_驗證調用次數及參數_VerifyAllExpectations()
		{
			//arrange
			var inject = MockRepository.GenerateMock<IInject>();
			inject.Expect(s => s.ReturnVoid(Arg<string>.Is.Equal(input))).Repeat.Times(1);

			var test = new TestClass(inject);

			//action

			test.ReturnVoid(input);

			//assert

			inject.VerifyAllExpectations();

		}
	}
}