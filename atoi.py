class Solution:
    def myAtoi(self, s: str) -> int:
        if s == '': return 0
        result_string = ''
        read_phase = 0 # 0 whitespace, sign or number, 1 check digit is after sign, 2 digits
        positive = True
        for i in range(0, len(s)): 
            character = s[i]
            if read_phase == 0:
                if character == ' ': continue
                if character == '0':
                    read_phase = 2
                    continue
                if character == '+' or character == '-':
                    positive = character != '-'
                    result_string = character
                    read_phase = 1
                    continue
                if (not character.isdigit()): return 0
                result_string = character
                read_phase = 2

                continue
            elif read_phase == 1:
                if (not character.isdigit()): return 0
                result_string += character
                read_phase = 2
            elif read_phase == 2:
                if not character.isdigit(): 
                    try:
                        if result_string == '': return 0
                        result = int(result_string)
                        if positive and result >= 2147483648: return 2147483647
                        elif not positive and result <= -2147483648: return -2147483648
                        return result
                    except:
                        return 2147483647 if positive else -2147483648
                    
                result_string+=character
        try:
            if result_string == '': return 0
            if result_string == '+' or result_string == '-': return 0
            result = int(result_string)
            if positive and result >= 2147483648: return 2147483647
            elif not positive and result <= -2147483648: return -2147483648
            return result
        except:
            return 2147483647 if positive else -2147483648