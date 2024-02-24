import { describe, expect, it, test } from 'vitest';
import { sum } from '../src/utils/sum';

//TODO: Run all these tests
test('adds 1 + 2 to equal 3', () => {
  //TODO: Go to definition of 'sum`
  expect(sum(1, 2)).toBe(3);
});

//TODO: Open the file `sum.ts` in another tab group so you have my.test.ts and sum.ts open at the same time
describe('sum func', () => {
  it('should be correct', () => {
    expect(sum(2, 2)).toBe(4);
  });
});
