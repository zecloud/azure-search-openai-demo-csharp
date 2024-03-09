// Copyright (c) Microsoft. All rights reserved.

namespace SharedWebComponents.Components;

public sealed partial class Examples
{
    [Parameter, EditorRequired] public required string Message { get; set; }
    [Parameter, EditorRequired] public EventCallback<string> OnExampleClicked { get; set; }

    private string WhatIsIncluded { get; } = "Y a t'il un article sur les Azure Functions ?";
    private string WhatIsPerfReview { get; } = "Quels sont les contributeurs du magazine ?";
    private string WhatDoesPmDo { get; } = "Qui est le rédacteur en chef ?";

    private async Task OnClickedAsync(string exampleText)
    {
        if (OnExampleClicked.HasDelegate)
        {
            await OnExampleClicked.InvokeAsync(exampleText);
        }
    }
}
