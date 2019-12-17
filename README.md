This adds a `formatsql` method to Transformalize using [Poor Man's T-SQL Formatter](https://github.com/TaoK/PoorMansTSqlFormatter).  It is a plug-in for Transformalize.

Build the Autofac project and put it's output into Transformalize's *plugins* folder.

Use like this:

```xml
<cfg name="Test">
    <connections>
        <add name="input" provider="internal" />
        <add name="output" provider="console" />
    </connections>
    <entities>
        <add name="Test">
            <rows>
                <add id="1" input-sql="select * from customers where name = 'google';" />
            </rows>
            <fields>
                <add name="id" type="int" />
                <add name="input-sql" length="4000" />
            </fields>
            <calculated-fields>
                <add name="output-sql" length="4000" t="copy(input-sql).formatsql()" />
            </calculated-fields>
        </add>
    </entities>
</cfg>
```

This produces:

```sql
SELECT *
FROM customers
WHERE NAME = 'google';
```