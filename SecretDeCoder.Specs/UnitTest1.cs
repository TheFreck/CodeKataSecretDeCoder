using Machine.Specifications;

namespace SecretDeCoder.Specs
{
    public class When_Decoding_A_String 
    {
        Establish context = () =>
        {
            input = new string[]
            {
                "B7eVz",
                "bhx,zWy",
                "yFeJ!c6LQS55bS95z 18IBIY$$$",
            };
            expect = new string[]
            {
                "noice",
                "abcdefg",
                "This! That? or The Other$$$"
            };
            answers = new string[expect.Length];
        };

        Because of = () =>
        {
            for (var i = 0; i < input.Length; i++)
            {
                answers[i] = CodeMachine.Decode(input[i]);
            }
        };

        It Should_Return_Decoded_String = () =>
        {
            for (var i = 0; i < answers.Length; i++)
            {
                answers[i].ShouldEqual(expect[i]);
            }
        };

        private static string[] input;
        private static string[] expect;
        private static string[] answers;
    }

}