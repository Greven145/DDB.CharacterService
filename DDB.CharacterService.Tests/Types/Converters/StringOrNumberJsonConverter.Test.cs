using DDB.CharacterService.Types;
using Xunit;
using System.Text.Json;
using FluentAssertions;

namespace DDB.CharacterService.Tests.Types.Converters; 

public class StringOrNumberJsonConverterTest {
    private class TestClass
    {
        public TestClass(StringOrNumber value) {
            Value = value;
        }

        public StringOrNumber Value{ get; }
    }
    
    [Fact]
    public void Write_WhenValueIsAString_StringIsWritten() {
        var actualValue = new TestClass("A test string");
        var actualJson = JsonSerializer.Serialize(actualValue);

        actualJson.Should().Be("{\"Value\":\"A test string\"}");
    }
    
    [Fact]
    public void Write_WhenValueIsANumber_NumberIsWritten()
    {
        var actualValue = new TestClass(123_456_789);
        var actualJson = JsonSerializer.Serialize(actualValue);

        actualJson.Should().Be("{\"Value\":123456789}");
    }

    [Fact]
    public void Read_WhenValueIsAString_StringIsRead()
    {
        const string testJson = "{\"Value\":\"A test string\"}";
        var actualValue = JsonSerializer.Deserialize<TestClass>(testJson);

        actualValue.Should().BeEquivalentTo(new TestClass("A test string"));
    }

    [Fact]
    public void Read_WhenValueIsANumber_NumberIsRead()
    {
        const string testJson = "{\"Value\": 123456789}";
        var actualValue = JsonSerializer.Deserialize<TestClass>(testJson);

        actualValue.Should().BeEquivalentTo(new TestClass(123_456_789));
    }
}