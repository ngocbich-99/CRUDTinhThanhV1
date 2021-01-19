import { test2TemplatePage } from './app.po';

describe('test2 App', function() {
  let page: test2TemplatePage;

  beforeEach(() => {
    page = new test2TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
