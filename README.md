# RhinoPractice
Rhino Practice




### 驗證沒有回傳值的函式的調用次數

使用 AssertWasCalled

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


使用 VerifyAllExpectations

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


### 驗證有回傳值的函式的調用次數

使用 VerifyAllExpectations

```c

//Arrange

inject.Expect(s => s.ToUpper(Arg<string>.Is.Equal(input))).Return(input.ToUpper()).Repeat.Times(1);

//Action

...

//Assert

inject.VerifyAllExpectations();

```