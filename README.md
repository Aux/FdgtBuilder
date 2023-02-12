[![Discord](https://discordapp.com/api/guilds/257698577894080512/widget.png)](https://discord.gg/yd8x2wM) 
[![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/Aux/FdgtBuilder/main.yml)](https://github.com/Aux/FdgtBuilder/actions/workflows/main.yml) 
[![Nuget](https://img.shields.io/nuget/v/FdgtBuilder)](https://www.nuget.org/packages/FdgtBuilder) 

## FdgtBuilder

Fluently create commands for https://github.com/fdgt-apis/api

### Builds

Latest builds are pushed automatically to Nuget at `https://www.nuget.org/packages/FdgtBuilder`

### Examples

To output: `"bits --bitscount 999999 Woohoo!"`

```cs
string command = Fdgt.UsingBits()
    .WithAmount(999999)
    .WithMessage("Woohoo!")
    .Build();
```

*With the `FdgtBuilder.TwitchLib` library*

```cs
client.SendBitsEvent(bits =>
{
    bits.WithAmount(999999);
    bits.WithMessage("Woohoo!");
});
```