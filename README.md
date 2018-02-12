# RhinoPractice
Rhino Practice




### ���ҨS���^�ǭȪ��禡���եΦ���

�ϥ� AssertWasCalled

```c

//Arrange

...

//Action

...

//Assert

inject.AssertWasCalled(
	mock => mock.ReturnVoid(Arg<string>.Is.Equal(input))
	, opt => opt.Repeat.Times(1)
);

```


�ϥ� VerifyAllExpectations

```c

//Arrange

var inject = MockRepository.GenerateMock<IInject>();
inject.Expect(s => s.ReturnVoid(Arg<string>.Is.Equal(input))).Repeat.Times(1);

//Action

...

//Assert

inject.VerifyAllExpectations();

```


---


### ���Ҧ��^�ǭȪ��禡���եΦ���

�ϥ� VerifyAllExpectations

```c

//Arrange

inject.Expect(s => s.ToUpper(Arg<string>.Is.Equal(input))).Return(input.ToUpper()).Repeat.Times(1);

//Action

...

//Assert

inject.VerifyAllExpectations();

```