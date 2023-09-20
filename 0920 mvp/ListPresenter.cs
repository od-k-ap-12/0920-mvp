using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0920_mvp
{
    public class ListPresenter
    {
        private readonly IModel _model;
        private readonly IListView _view;

        public ListPresenter(IModel model, IListView view)
        {
            _model = model;
            _view = view;
            _view.SaveEvent += new EventHandler<EventArgs>(OnSave);
            _view.ShowAllEvent += new EventHandler<EventArgs>(OnShowAll);
        }

        private void OnSave(object sender, EventArgs e)
        {
            try
            {
                _model.PersonName=_view.PersonName;
                _model.PersonAge=_view.PersonAge;
                _model.Save();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void OnShowAll(object sender, EventArgs e)
        {
            try
            {
                _view.People = _model.ShowAll();

            }
            catch (Exception)
            {
                throw;
            }

            UpdateView();
        }

        private void UpdateView()
        {
            _view.PersonAge=_model.PersonAge;
            _view.PersonName = _model.PersonName;
        }
    }
}
