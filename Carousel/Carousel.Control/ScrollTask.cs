using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carousel.Control;

internal class ScrollTask
{
    private static TimeSpan _scrollDelay = TimeSpan.FromMilliseconds(50);

    private CollectionView _collectionView;

    private int _currentIndex;

    private volatile bool _scrolling;

    public ScrollTask(CollectionView collectionView)
    {
        _collectionView = collectionView;
    }

    public int CurrentIndex => _currentIndex;

    public void ScrollLeft()
    {
        _scrolling = true;

        ScrollLeftInternal();
    }

    private void ScrollLeftInternal()
    {
        IEnumerable<View> items = (IEnumerable<View>)_collectionView.ItemsSource;

        int count = items.Count();

        if (_currentIndex > 0 && _scrolling)
        {
            _currentIndex--;
            _collectionView.ScrollTo(_currentIndex, position: ScrollToPosition.Start, animate: true);

            if (_scrolling)
            {
                _collectionView.Dispatcher.DispatchDelayed(_scrollDelay, ScrollLeftInternal);
            }
        }
    }

    public void ScrollRight()
    {
        _scrolling= true;

        ScrollRightInternal();
    }

    private void ScrollRightInternal()
    {
        IEnumerable<View> items = (IEnumerable<View>)_collectionView.ItemsSource;

        int count = items.Count();

        if (_currentIndex < count - 1 && _scrolling)
        {
            _currentIndex++;
            _collectionView.ScrollTo(_currentIndex, position: ScrollToPosition.Start, animate: true);

            _collectionView.Dispatcher.DispatchDelayed(_scrollDelay, ScrollRightInternal);
        }
    }

    public void Stop()
    {
        _scrolling = false;
    }
}
