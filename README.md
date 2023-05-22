# emailvalidation-dotnet

emailvalidation-dotnet is the official C# Wrapper around the [emailvalidation](https://app.emailvalidation.io) API.

## Configuration

You will need your apikey to use Emailvalidation, you can get one [https://app.emailvalidation.io/register](https://app.emailvalidation.io/register).

Create an instance and pass your api key like here:

    var mail = new Emailvalidation("[YOUR_API_KEY]");

## Usage & Endpoints

Use the instance to call the endpoints

#### Status
Returns your current quota

    mail.Status()

#### Info
Checks the provided email address and returns all available information.

    mail.Info(email, catch_all)

  | Parameter | Data type | Mandatory | Description |
  |-----------| ----------- | --- | ----------- |
  | email | string    | yes | The email address you want to check  |
  | catch_all | boolean   | no | If set to 1 we check if the email domain is a catch-all enabled domain (Only available in higher up plans)  |


You can find further information on https://emailvalidation.io/docs/

## Contributing

1. Fork it
2. Create your feature branch (`git checkout -b my-new-feature`)
3. Commit your changes (`git commit -am 'Added some feature'`)
4. Push to the branch (`git push origin my-new-feature`)
5. Create new Pull Request

Bug reports and pull requests are welcome on GitHub at https://github.com/everapihq/emailvalidation-dotnet. This project is intended to be a safe, welcoming space for collaboration, and contributors are expected to adhere to the [code of conduct](https://github.com/everapihq/emailvalidation-dotnet/blob/master/CODE_OF_CONDUCT.md).

## License

The gem is available as open source under the terms of the [MIT License](https://opensource.org/licenses/MIT).

## Code of Conduct

Everyone interacting in the Emailvalidation project's codebases, issue trackers, chat rooms and mailing lists is expected to follow the [code of conduct](https://github.com/everapihq/emailvalidation-dotnet/blob/master/CODE_OF_CONDUCT.md).
