using System.Collections.Generic;
using WebApi.Models;
using System.Linq;

namespace WebApi.Repository {

    public class PropertyRepo {

        private List<Property> _properties;

        public PropertyRepo() {
            _properties = new List<Property>();
        }

        public void Create(Property property) {
            _properties.Add(property);
        }

        public Property Get(int i) {
            return _properties.Where(p => p.Id == i).FirstOrDefault();
        }
    }
}