using CorebitzApi.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace CorebitzApi.Entities
{
    public class Genre : IValidatableObject
    {
        public Genre()
        {
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "The field with name {0} is required")]
        [StringLength(10)]
        //[FirstLetterUppercase]
        public string Name { get; set; }

        [Range(18, 100)]
        public string Age { get; set; }

        [CreditCard]
        public string CreditCard { get; set; }

        [Url]
        public string Url { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(Name))
            {
                var firstLetter = Name[0].ToString();
                if (firstLetter != firstLetter.ToUpper())
                {
                    yield return new ValidationResult("First letter should be uppercase", [nameof(Name)]);
                }
                {

                }
            }
            //throw new NotImplementedException();
        }
    }
}

 