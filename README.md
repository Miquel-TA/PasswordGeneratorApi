# Password Generator API

This small API generates passwords that strike a balance between security and memorability. The passwords are based on random combinations of English words, special symbols, and numbers, making them easier to remember than fully random passwords while still being significantly more secure than typical passwords.

## Key Features
- **Fairly Secure**: Utilizes cryptographically secure random number generation (`RandomNumberGenerator`) for unpredictable word, symbol, and number combinations.
- **Memorable**: Combines three random words from a 139k wordlist alongside symbols and numbers, creating passwords that are both secure and easier to recall.
- **Better than Most**: While not the most secure solution, as the pattern does not change, it offers a solid compromise between security and user-friendly passwords.
- **Resistant to Dictionary Attacks**: Even if the wordlist and pattern are known, the number of possible combinations makes a dictionary attack highly impractical.
- **Brute-force Resistance**: The minimum password length of 18 ensures that brute-force attempts are very unlikely to succeed.

## Password Structure
- **Three English words** (from a preloaded wordlist)
- **Two random symbols** (from a limited set of special characters)
- **One random number** (0-9)

## Security Considerations
While this API does not produce the most secure passwords, it still offers a substantial number of combinations to resist typical attacks:

- **Combinations**: With 139,000 words, two symbols and a random number, there are approximately **3.48 quadrillion** possible combinations of passwords.
- **Hashing Protection**: Even if this password is hashed using an obsolete method and the wordlist and pattern are known, the high number of possible combinations and the minimum password length make cracking pretty unlikely, as it would take substantial resources to brute-force.
- **Cracking Time Estimates**: 
  - At **200GH/s** (200 billion combinations per second), it would take approximately **200 days** to brute-force all combinations (with known pattern and known dictionary).
  - ((139,000×139,000×139,000)×(12×12)×9) / 200,000,000,000 / 60 / 60 / 24

## Considerations
This API is ideal for generating passwords that are significantly more secure than common weak passwords, while still being practical for everyday use. However, it’s not intended to meet the highest levels of cryptographic security, such as for highly sensitive systems.
