namespace Carousel.Control;

public partial class CarouselView : ContentView
{
    public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create(nameof(ItemsSource), typeof(IEnumerable<View>), typeof(CarouselView), propertyChanged: OnItemsSourcePropertyChanged);

    private int _currentIndex = 0;

    private ScrollTask _scrollTask;

    public CarouselView()
	{
		InitializeComponent();

        _scrollTask = new ScrollTask(CarouselArea);
	}

    public IEnumerable<View> ItemsSource
    {
        get => (IEnumerable<View>)GetValue(ItemsSourceProperty);
        set => SetValue(ItemsSourceProperty, value);
    }

    public static void OnItemsSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        CarouselView view = (CarouselView)bindable;
        IEnumerable<View> itemsSource = (IEnumerable<View>)newValue;
        view.CarouselArea.ItemsSource = itemsSource;
    }

    private void LeftPointerDown(object sender, PointerEventArgs e)
    {
        _scrollTask.ScrollLeft();
    }
    
    private void LeftPointerUp(object sender, PointerEventArgs e)
    {
        _scrollTask.Stop();
    }

    private void RightPointerDown(object sender, PointerEventArgs e)
    {
        _scrollTask.ScrollRight();
    }

    private void RightPointerUp(object sender, PointerEventArgs e)
    {
        _scrollTask.Stop();
    }
}