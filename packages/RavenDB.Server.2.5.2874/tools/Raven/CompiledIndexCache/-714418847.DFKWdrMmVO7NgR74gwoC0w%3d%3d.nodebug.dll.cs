using Raven.Abstractions;
using Raven.Database.Linq;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
using Raven.Database.Linq.PrivateExtensions;
using Lucene.Net.Documents;
using System.Globalization;
using System.Text.RegularExpressions;
using Raven.Database.Indexing;


public class Index_Auto_2fEmployees_2fByFirstName : Raven.Database.Linq.AbstractViewGenerator
{
	public Index_Auto_2fEmployees_2fByFirstName()
	{
		this.ViewText = @"from doc in docs.Employees
select new { FirstName = doc.FirstName }";
		this.ForEntityNames.Add("Employees");
		this.AddMapDefinition(docs => 
			from doc in docs
			where string.Equals(doc["@metadata"]["Raven-Entity-Name"], "Employees", System.StringComparison.InvariantCultureIgnoreCase)
			select new {
				FirstName = doc.FirstName,
				__document_id = doc.__document_id
			});
		this.AddField("FirstName");
		this.AddField("__document_id");
		this.AddQueryParameterForMap("FirstName");
		this.AddQueryParameterForMap("__document_id");
		this.AddQueryParameterForReduce("FirstName");
		this.AddQueryParameterForReduce("__document_id");
	}
}
