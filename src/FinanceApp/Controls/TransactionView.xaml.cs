namespace FinanceApp.Controls;

public partial class TransactionView : ContentView
{
	public TransactionView()
	{
		InitializeComponent();

        BindingContext = this;
    }

    public static BindableProperty IconProperty = BindableProperty.Create(propertyName: nameof(Icon), returnType: typeof(string), declaringType: typeof(TransactionView),
       defaultValue: string.Empty, defaultBindingMode: BindingMode.TwoWay);

    public string Icon
    {
        get { return GetValue(IconProperty).ToString(); }
        set { SetValue(IconProperty, value); }
    }

    public static BindableProperty TitleProperty = BindableProperty.Create(propertyName: nameof(Title), returnType: typeof(string), declaringType: typeof(TransactionView),     
        defaultValue: string.Empty, defaultBindingMode: BindingMode.TwoWay);
    
    public string Title
    {
        get { return GetValue(TitleProperty).ToString(); }
        set { SetValue(TitleProperty, value); }
    }

    public static BindableProperty DescriptionProperty = BindableProperty.Create(propertyName: nameof(Description), returnType: typeof(string), declaringType: typeof(TransactionView),
        defaultValue: string.Empty, defaultBindingMode: BindingMode.TwoWay);

    public string Description
    {
        get { return GetValue(DescriptionProperty).ToString(); }
        set { SetValue(DescriptionProperty, value); }
    }

    public static BindableProperty PriceProperty = BindableProperty.Create(propertyName: nameof(Price), returnType: typeof(string), declaringType: typeof(TransactionView),
       defaultValue: string.Empty, defaultBindingMode: BindingMode.TwoWay);

    public string Price
    {
        get { return GetValue(PriceProperty).ToString(); }
        set { SetValue(PriceProperty, value); }
    }
}