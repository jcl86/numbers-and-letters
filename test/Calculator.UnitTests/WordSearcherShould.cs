using Calculator.Infraestructure;
using FluentAssertions;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.UnitTests
{
    public class WordSearcherShould
    {
        [Fact]
        public async Task Find_existing_word()
        {
            var wordSearcher = new DraeWordSearcher();

            var result = await wordSearcher.Search("ejemplo");
            result.Should().Be(new DictionaryWord("ejemplo", "https://dle.rae.es/ejemplo"));
        }

        [Fact]
        public async Task Not_find_invented_word()
        {
            var wordSearcher = new DraeWordSearcher();

            var result = await wordSearcher.Search("enchiridion");
            result.Should().BeNull();
        }
    }
}
