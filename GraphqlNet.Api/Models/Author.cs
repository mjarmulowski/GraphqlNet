using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlNet.Api.Models;

public class Author
{
    public required Guid ID { get; set; }
    public Guid PersonID { get; set; }
    public List<Book> Books { get; set; } = [];

    public required Person Person { get; set; }
}
