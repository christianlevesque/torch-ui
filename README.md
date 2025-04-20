# TorchUI

TorchUI is a collection of packages that define Blazor Static SSR components.

## Available frameworks

- `TorchUI.Bootstrap` - Blazor Static SSR library based on [Bootstrap 5](https://getbootstrap.com/docs/5.3/)

## Justification

Blazor is an amazing piece of technology. However, it's still quite heavy when not used in ideal circumstances: Blazor WASM apps get big fast, and Blazor Server apps are network-bound. This doesn't mean Blazor is useless - far from it - but it *does* limit the places where Blazor is useful.

However, when using Blazor in Static SSR mode, the browser sees a static HTML website. If you want interactivity, just add some Javascript. This creates a development environment that looks and feels like Blazor, but has the static HTML output of Razor Pages/MVC. When used in this way, Blazor is the best of both worlds - no more `<partial>` or `<vc>` tags, but your app still performs well on $20 smartphones and computers in the middle of Nebraska running Windows Vista\*.

\**Actually, probably not. Do not attempt.*